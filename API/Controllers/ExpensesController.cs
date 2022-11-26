using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly DataContext context;

        public ExpensesController(DataContext context)
        {
            this.context = context;
        }

        // get api/expenses
        [HttpGet(Name = "GetExpenses")]
        public ActionResult<List<Expense>> Get()
        {
            return this.context.Expenses.ToList();
        }

        //get api/expense/[id]
        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Expense> GetById(Guid id)
        {
            var expense = this.context.Expenses.Find(id);
            if (expense is null)
            {
                return NotFound();
            }

            return Ok(expense);
        }

        ///Post api/expense
        /// <param name="request">JSON request containing expense fields</param>
        /// <returns>A new expense</returns>
        [HttpPost(Name = "Create")]
        public ActionResult<Expense> Create([FromBody]Expense request)
        {
            var expense = new Expense
            {
                Id = Guid.NewGuid(),
                expenseName = request.expenseName,
                business = request.business,
                amount = request.amount,
                paymentStatus = "Unpaid"
            };

            context.Expenses.Add(expense);
            var success = context.SaveChanges() > 0;

            if (success)
            {
                return Ok(expense);
            }

            throw new Exception("Error adding expense");
        }

        /// put api/expense
        /// <returns>An updated expense</return>
        [HttpPut(Name = "Update")]
        public ActionResult<Expense> Update([FromBody]Expense request)
        {
            var expense = context.Expenses.Find(request.Id);
            if (expense == null)
            {
                throw new Exception("Could not find expense");
            }

            //update the post properties with request values, if present
            expense.expenseName = request.expenseName != null ? request.expenseName : expense.expenseName;
            expense.business = request.business != null ? request.business : expense.business;
            expense.amount = request.amount > 0 ? request.amount : expense.amount;
            expense.paymentStatus = request.paymentStatus != null ? request.paymentStatus : expense.paymentStatus;

            var success = context.SaveChanges() > 0;

            if(success)
            {
                return Ok(expense);
            }

            throw new Exception("Error updating expense");
        }

        // delete api/expense/[id]
        [HttpDelete("{id}", Name = "Delete")]
        public ActionResult<Expense> Delete(Guid id)
        {
            var expense = this.context.Expenses.Find(id);
            if (expense is null)
            {
                return NotFound();
            }

            var item = context.Expenses.Where(item => item.Id == expense.Id).Single();
            context.Expenses.Remove(expense);

            var success = context.SaveChanges() > 0;
            
            if(success)
            {
                return Ok(expense);
            }
            
            throw new Exception("Error deleting expense");
        }
    }
}