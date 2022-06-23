using System;
using System.Collections.Generic;
using System.Text;
using eShopOnContainers.Core.Models.MyHome;

namespace eShopOnContainers.Core.Services.MyHome
{
    public class MyHomeMockService : IHomeService
    {

        private readonly static List<Banner> Banners = new List<Banner>()
        {
             new Banner()
                {
                    Image = "firsaturunu1.png"
                },
                new Banner()
                {
                    Image = "firsaturunu2.png"
                },
                new Banner()
                {
                    Image = "firsaturunu3.png"
                },
                new Banner()
                {
                    Image = "firsaturunu4.png"
                },
                new Banner()
                {
                    Image = "firsaturunu5.png"
                },
                new Banner()
                {
                    Image = "firsaturunu6.png"
                },
                new Banner()
                {
                    Image = "firsaturunu7.png"
                },
                new Banner()
                {
                    Image = "firsaturunu8.png"
                },
                new Banner()
                {
                    Image = "firsaturunu9.png"
                },
                new Banner()
                {
                    Image = "firsaturunu10.png"
                }
        };


        public List<Banner> GetBanners()
        {
            return Banners;
        }
    }
}
