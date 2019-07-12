using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Learning_Session_1.Models
{
    public class MathOperations
    {
        public decimal Value1 { get; set; }
        public decimal Value2 { get; set; }
        public decimal Result { get; set; }
        public string Operation { get; set; }
        public decimal Addition()
        {
            return Value1 + Value2;
        }
        public decimal Subtraction()
        {
            return Value1 - Value2;
        }
        public decimal Multiplication()
        {
            return Value1 * Value2;
        }
        public decimal Division()
        {
            return Value1 / Value2;
        }
        public void Operations(MathOperations obj)
        {
            string opName = obj.Operation.ToUpper();
            if (opName == "") {
                obj.Result= 0;
            }
            if (opName == "ADDITION")
            {
                obj.Result = obj.Value1 + obj.Value2;
            }
            else if(opName == "SUBTRACTION")
            {
                obj.Result = obj.Value1 - obj.Value2;
            }
            else if (opName == "MULTIPLICATION")
            {
                obj.Result = obj.Value1 * obj.Value2;
            }
            else if (opName == "DIVISON")
            {
                obj.Result = obj.Value1 / obj.Value2;
            }
        }
    }
}