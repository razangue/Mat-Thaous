using RaysHotDogs.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaysHotDogs.Core.Repository
{
    public class HotDogRepository
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
            new HotDogGroup()
            {
                HotDogGroupId=1, Title= "Meat Lovers",ImagePath="", HotDogs =new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=1,
                        Name ="Regular Hot Dog",
                        ShortDescription="The best there in on this planet",
                        Description ="Machego smelly cheese danish fortina. Hard cheese",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime=10,
                        Ingredients = new List<string>(){"Regular bun", "Sausage","Cheese","Ketchup"},
                        Price = 8,
                        IsFavorite= true
                    },
                    new HotDog()
                    {
                        HotDogId=2,
                        Name ="Haute Dog",
                        ShortDescription="The classic one",
                        Description ="Bacon ipsum dolor amet",
                        ImagePath="hotdog2",
                        Available=true,
                        PrepTime=15,
                        Ingredients = new List<string>(){"Regular bun", "Gourmet Sausage","Cheese","Ketchup"},
                        Price = 10,
                        IsFavorite= false
                    },
                    new HotDog()
                    {
                        HotDogId=3,
                        Name ="Extra Long",
                        ShortDescription="For when a regular one isn't enough",
                        Description ="Capicola short loin shoulder strip streak",
                        ImagePath="hotdog3",
                        Available=true,
                        PrepTime=10,
                        Ingredients = new List<string>(){"Extra long bun", "Extra long Sausage","Cheese","Ketchup"},
                        Price = 8,
                        IsFavorite= true
                    }
                }
            },
            new HotDogGroup()
            {
                HotDogGroupId=2, Title= "Veggie Lovers",ImagePath="", HotDogs =new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=4,
                        Name ="Veggie Hot Dog",
                        ShortDescription="American for non-meat-lovers",
                        Description ="Veggie es bonus vobis, proinde vos postulo",
                        ImagePath="hotdog4",
                        Available=true,
                        PrepTime=10,
                        Ingredients = new List<string>(){"Bun", "Vegetarian sausage","Cheese","Ketchup"},
                        Price = 8,
                        IsFavorite= false
                    },
                    new HotDog()
                    {
                        HotDogId=2,
                        Name ="Haute Dog Veggie",
                        ShortDescription="Classic and veggie",
                        Description ="Green hot dog",
                        ImagePath="hotdog5",
                        Available=true,
                        PrepTime=15,
                        Ingredients = new List<string>(){"Backed bun", "Gourmet vegetarian Sausage","Cheese","Ketchup"},
                        Price = 10,
                        IsFavorite= false
                    },
                    new HotDog()
                    {
                        HotDogId=6,
                        Name ="Extra Long Veggie",
                        ShortDescription="For when a regular one isn't enough",
                        Description ="The best veggie hot dog",
                        ImagePath="hotdog6",
                        Available=true,
                        PrepTime=10,
                        Ingredients = new List<string>(){"Extra long bun", "Extra long Sausage","Cheese","Ketchup"},
                        Price = 8,
                        IsFavorite= false
                    }
                }
            }
        };

        public List<HotDog> GetAllHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                select hotDog;
            return hotDogs.ToList<HotDog>();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.HotDogId == hotDogId
                select hotDog;
            return hotDogs.FirstOrDefault();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogGroups;
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            var group = hotDogGroups.Where(h => h.HotDogGroupId == hotDogGroupId).FirstOrDefault();
            if (group != null)
            {
                return group.HotDogs;
            }
            return null;
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.IsFavorite
                select hotDog;
            return hotDogs.ToList<HotDog>();
        }
    }
}
