using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam efficitur odio erat, id sollicitudin orci tristique non. In consectetur, dolor a posuere maximus, elit ex fermentum risus, quis accumsan massa odio vel ipsum. Fusce blandit ex turpis, sit amet aliquam enim condimentum in. Aenean id diam maximus, fermentum tortor vitae, facilisis neque. Duis quis augue in justo tristique placerat sit amet vel est. Nulla facilisi. Interdum et malesuada fames ac ante ipsum primis in faucibus. Cras vestibulum mi eu porttitor lacinia. Duis elementum diam odio, ut volutpat elit viverra sed. Nam elementum libero a lacus pharetra aliquet. Vestibulum ullamcorper, nulla eu commodo elementum, massa quam sollicitudin risus, aliquet ultrices lectus massa maximus massa. Fusce maximus, nisl at varius fringilla, dui massa ultricies augue, id venenatis risus sem dapibus mi. Quisque dignissim, lorem at imperdiet dapibus, ipsum mi egestas justo, et ornare dolor arcu et nulla. Cras bibendum interdum augue, sed lobortis velit tristique eget. Quisque ut nunc at magna pretium mattis ut quis eros.",
                        Date = DateTime.Now.AddDays(-10)
                        },
                    new Post {
                        Title = "Second post",
                        Body = "Duis quis augue rutrum justo feugiat convallis id non arcu. Vestibulum cursus lectus at turpis viverra condimentum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Morbi pharetra mi sit amet arcu hendrerit venenatis. Integer et felis diam. Integer laoreet risus ut sem ullamcorper, vitae venenatis turpis tincidunt. Donec auctor, mauris vitae malesuada luctus, tellus lectus euismod justo, vel bibendum libero risus eu diam. Vivamus convallis lacus in velit posuere suscipit. Morbi sodales sollicitudin nisl. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla facilisi. Donec nec felis et neque ullamcorper sollicitudin ac eget neque. Phasellus pellentesque pretium tristique. Donec fringilla vehicula blandit. Integer pulvinar tortor lorem, sed auctor justo congue id.",
                        Date = DateTime.Now.AddDays(-7)
                        },
                    new Post {
                        Title = "Third post",
                        Body = "In sit amet augue massa. Nullam pellentesque tincidunt eros quis viverra. Fusce dignissim posuere mauris, ut varius dui venenatis quis. Vivamus feugiat lectus sit amet fringilla finibus. Nunc sodales, massa non sollicitudin posuere, dui urna gravida dui, at faucibus velit purus quis orci. Ut gravida venenatis orci, ac dignissim urna volutpat ac. Phasellus egestas tortor ut dolor placerat, et accumsan lacus efficitur. Sed blandit, odio nec finibus euismod, massa nisl maximus magna, egestas pellentesque felis est a justo.",
                        Date = DateTime.Now.AddDays(-4)
                        }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}