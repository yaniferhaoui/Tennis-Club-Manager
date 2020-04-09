using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class Enumerations
    {
        public enum Gender
        {
            [Description("Homme")]
            MALE = 0,
            [Description("Femme")]
            FEMALE = 1
        }

        public enum RegistrationType
        {
            [Description("Loisir")]
            LEISURE = 0,
            [Description("Compétition")]
            COMPETITION = 1
        }

        public enum Status
        {
            [Description("Indépendant")]
            FREELANCE = 0,
            [Description("Salarié")]
            EMPLOYEE = 1
        }

        public enum MatchType
        {
            [Description("Match Simple Homme")]
            SINGLE_MEN = 0,
            [Description("Match Simple Femme")]
            SINGLE_WOMEN = 1,
            [Description("Match Simple Homme Junior")]
            SINGLE_MEN_JUNIOR = 2,
            [Description("Match Simple Femme Junior")]
            SINGLE_WOMEN_JUNIOR = 3,
            [Description("Match Double Homme")]
            DOUBLE_MEN = 4,
            [Description("Match Double Femme")]
            DOUBLE_WOMEN = 5,
            [Description("Match Double Homme Junior")]
            DOUBLE_MEN_JUNIOR = 6,
            [Description("Match Double Femme Junior")]
            DOUBLE_WOMEN_JUNIOR = 7
        }

        public enum Level
        {
            [Description("NC")]
            A = 250,
            [Description("40")]
            B = 240,
            [Description("30/5")]
            C = 230,
            [Description("30/4")]
            D = 220,
            [Description("30/3")]
            E = 210,
            [Description("30/2")]
            F = 200,
            [Description("30/1")]
            G = 190,
            [Description("30")]
            H = 180,
            [Description("15/5")]
            I = 170,
            [Description("15/4")]
            J = 160,
            [Description("15/3")]
            K = 150,
            [Description("15/2")]
            L = 140,
            [Description("15/1")]
            M = 130,
            [Description("15")]
            N = 120,
            [Description("5/6")]
            O = 110,
            [Description("4/6")]
            P = 100,
            [Description("3/6")]
            Q = 90,
            [Description("2/6")]
            R = 80,
            [Description("1/6")]
            S = 70,
            [Description("0")]
            T = 60,
            [Description("-2/6")]
            U = 50,
            [Description("-4/6")]
            V = 40,
            [Description("-15")]
            W = 30,
            [Description("-30")]
            X = 20,
            [Description("TOP 100")]
            Y = 10,
            [Description("TOP 60")]
            Z = 0
        }

        public static string GetDescription(Enum value)
        {
            return
                value
                    .GetType()
                    .GetMember(value.ToString())
                    .FirstOrDefault()
                    ?.GetCustomAttribute<DescriptionAttribute>()
                    ?.Description
                ?? value.ToString();
        }
        public static T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", nameof(description));

        }
    }
}
