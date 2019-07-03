using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{
    public class GreedyTimes
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] safeItems = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gems = 0;
            long cash = 0;

            for (int i = 0; i < safeItems.Length; i += 2)
            {
                string itemName = safeItems[i];
                long itemQuantity = long.Parse(safeItems[i + 1]);

                string treasureType = string.Empty;

                //Determening the type of treasure we have as input
                if (itemName.Length == 3)
                {
                    treasureType = "Cash";
                }
                else if (itemName.ToLower().EndsWith("gem"))
                {
                    treasureType = "Gem";
                }
                else if (itemName.ToLower() == "gold")
                {
                    treasureType = "Gold";
                }

                //Skip conditions in case the input isn't gold gems or cash or that the bag capacity is insuficient
                if (treasureType == "")
                {
                    continue;
                }
                else if (bagCapacity < (gold + gems + cash + itemQuantity))
                {
                    continue;
                }


                //Skip conditions in case the rules are not followed (gold >= gems; gems >= cash) 
                switch (treasureType)
                {
                    case "Gem":
                        if (!bag.ContainsKey("Gem"))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (itemQuantity > gold)
                                {
                                    //We skip the input
                                    continue;
                                }
                                //In case the bag contains any "gold" and the gem quantity is under that of the gold we don't skip the cycle step.
                            }
                            else
                            {
                                //We skip the input
                                continue;
                            }
                        }
                        else if (gems + itemQuantity > gold)
                        {
                            //We have some gold in the bag and it it's quantity is more than that of the gems, now we check if adding the amount of the input will tip the balance
                            continue;
                        }
                        break;

                    //Repeating the same logic with "gem > cash" rule
                    case "Cash":
                        if (!bag.ContainsKey("Cash"))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (itemQuantity > gems)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (cash + itemQuantity > gems)
                        {
                            continue;
                        }
                        break;

                }

                // If we haven't skipped the cycle step this far, we check if we have the dictionary entries for the treasure category and item respectievly
                if (!bag.ContainsKey(treasureType))
                {
                    bag[treasureType] = new Dictionary<string, long>();
                }

                if (!bag[treasureType].ContainsKey(itemName))
                {
                    bag[treasureType][itemName] = 0;
                }

                //Adding the treasure in it's respective category and type
                bag[treasureType][itemName] += itemQuantity;

                //Storing the specific amount of any treasure in a separate variable so to spare ourselves the tedium of writing LINQ queries every time we need it
                if (treasureType == "Gold")
                {
                    gold += itemQuantity;
                }
                else if (treasureType == "Gem")
                {
                    gems += itemQuantity;
                }
                else if (treasureType == "Cash")
                {
                    cash += itemQuantity;
                }
            }

            //Printing the results
            foreach (var treasureType in bag)
            {
                Console.WriteLine($"<{treasureType.Key}> ${treasureType.Value.Values.Sum()}");

                foreach (var treasureItem in treasureType.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{treasureItem.Key} - {treasureItem.Value}");
                }
            }
        }
    }
}