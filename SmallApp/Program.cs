using System;
using System.Collections.Generic;

namespace SmallApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>() { new XSClubPromoter("Jon", "Jones", 7637328972), new XSClubPromoter("Jonas", "Jones", 7637328973), new OmniaClubPromoter("Jane", "James", 7635674563)};

            foreach(var promoter in promoters)
            {
                promoter.Promote();
            }

            List<Writer> writers = new List<Writer>() { new BookWriter("Jon", "Jones"), new BookWriter("Jonas", "Jones"), new BlogWriter("Jane", "James")};

            foreach(var writer in writers)
            {
                writer.Write();
            }

            List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>() { new XSClubPromoter("Jon", "Jones", 7637328972), new XSClubPromoter("Jonas", "Jones", 7637328973)};

            foreach(var bodyBuilder in bodyBuilders)
            {
                bodyBuilder.Workout();
            }

            List<IVlogger> vloggers = new List<IVlogger>() { new XSClubPromoter("Jon", "Jones", 7637328972), new BookWriter("Jonas", "Jones")};

            foreach(var vlogger in vloggers)
            {
                vlogger.Vlog();
            }
        }
    }
}
