using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Common;

namespace g.HandyHaversacks
{
    class HandyHaversacks
    {
        static void Main(string[] args)
        {
            string[] bagRules = Input.GetInput(7).Split("\n");
            var parsed = ParseBagRelations(bagRules);
            var onlyIds = parsed.Select(itm => (itm.Key, itm.Value.Select(tpl => tpl.id).ToList()))
                .ToDictionary(itm => itm.Key, itm => itm.Item2);
            var answerRelationship = CountRelationships(onlyIds, new List<string>() {"shiny gold bag"}, new List<string>());
            var answerContain = CountRequiredBags(parsed, new List<string>() {"shiny gold bag"});
            Console.WriteLine(answerRelationship);
            Console.WriteLine(answerContain);
            Console.WriteLine("Hello World!");
        }

        private static int CountRequiredBags(Dictionary<string, List<(int count, string type)>> relatonships, List<string> target)
        {
            int result = 0;
            foreach (var item in target)
            {
                result += relatonships[item].Sum(pair => pair.count);
                result += relatonships[item].Sum(pair =>  CountRequiredBags(relatonships, new List<string>() {(pair.type)}) * pair.count);
            }
            return result;
        }

        private static int CountRelationships(Dictionary<string, List<string>> relatonships, List<string> target, List<string> visistedContainers)
        {
            int result = 0;
            foreach (var item in target)
            {
                var containers = relatonships.Where(rl => rl.Value.Contains(item)).Select(rl => rl.Key).ToList();
                result += containers.Count(c => !visistedContainers.Contains(c));
                visistedContainers.AddRange(containers);
                result += CountRelationships(relatonships, containers, visistedContainers);
            }
            return result;
        }

        private static Dictionary<string, List<(int count, string id)>> ParseBagRelations(string[] rules)
        {
            Dictionary<string, List<(int, string)>> dict = new Dictionary<string, List<(int,string)>>();
            Regex regex = new Regex("[0-9].");
            foreach (var rule in rules)
            {
                var components = rule.Replace("bags", "bag").Split("contain");
                var matches = regex.Matches(components[1]);
                var clean = Regex.Replace(components[1], "([0-9]*)", "").Replace(".", "").Trim();
                var cleanSplit = clean.Split(",");
                List<(int, string)> relationships = new List<(int, string)>();
                for (int i = 0; i < matches.Count; i++)
                {
                    relationships.Add((int.Parse(matches[i].Value), cleanSplit[i].Trim()));
                }
                dict.Add(components[0].Trim(), relationships);
            }

            // foreach (var pair in dict)
            //     Console.WriteLine($"{pair.Key} has {pair.Value.Count} dependencies - {string.Join(", ", pair.Value.Select(v => v.Item2))}");

            return dict;
        }
    }
}