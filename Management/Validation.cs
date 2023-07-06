using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public class Validation
    {
        //validate all fieds
        public bool isEmpty(string id, string name, string price, string quantity)
        {
            if (id == "" || name == "" || price == "" || quantity == "")
            {
                return true;
            }
            return false;
        }

        public bool isEmpty(string input)
        {
            if (input == "")
            {
                return true;
            }
            return false;
        }

        public string formatID(string id)
        {
            string result = "";
            //id must be start with "SW"+ number(vd SW001) 001->999. If not, return to result a message to tell user
            if (id.Length == 5)
            {
                if (id.Substring(0, 2) == "SW")
                {
                    try
                    {
                        int number = int.Parse(id.Substring(2, 3));
                        if (number >= 1 && number <= 999)
                        {
                            result = id;
                        }
                    }
                    catch (Exception)
                    {
                        result = "ID must be start with SW and follow by 3 numbers from 001";
                    }
                }
                else
                {
                    result = "ID must be start with SW";
                }
            }
            else
            {
                result = "ID wrong format";
            }
            return result;
        }

        public string isName(string name)
        {
            string result = "";
            //check name is not number and not empty
            if (name.Length > 0)
            {
                if (name.Any(char.IsLetter))
                {
                    result = name;
                }
                else
                {
                    result = "Name must be not number";
                }
            }
            return result;
        }

        public decimal isPrice(string price)
        {
            decimal result = 0;
            try
            {
                result = decimal.Parse(price);
                if (result <= 0)
                {
                    result = -2;
                }
            }
            catch (Exception)
            {
                result = -1;
            }
            return result;
        }

        public int isQuantity(string quantity)
        {
            int result = 0;
            try
            {
                result = int.Parse(quantity);
                if (result <= 0)
                {
                    result = -2;
                }
            }
            catch (Exception)
            {
                result = -1;
            }
            return result;
        }
    }
}
