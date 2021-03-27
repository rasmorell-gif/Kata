using System;
using System.Collections.Generic;

namespace kata_prueba8
{
    public class StringCalculator
    {
        public int Add (string numbers)
        {
            if (numbers == ""){
                return 0; 
            }    
          
                        
            char delimiter = ' ';
            if (numbers.Contains("//"))
            {
                delimiter = numbers[2];
            } 

            else if (numbers.Contains("+"))
            {
                delimiter = numbers[1];
            }
            

            else
            {
                delimiter = ',';
            }
                string delimiterTs = delimiter.ToString();
                var replace = numbers.Replace("//", delimiterTs).Replace("\n", delimiterTs);
                var separedNumbers = replace.Split(delimiterTs);

                int result = SumaArrayValues(separedNumbers);
                return result;

           
                
        }      
         private int SumaArrayValues(string[] separedNumbers) 
        {


                int result = 0;

                var negativeNumbers = "";

                for(int i = 0; i < separedNumbers.Length; i++)
                {   
                    if (separedNumbers[i] == "")
                    {

                    } 

                    else if (Convert.ToInt32(separedNumbers[i]) > 1000)
                   {

                   }

                    else 
                    {

                        var number = Convert.ToInt32(separedNumbers[i]);
                        if (number < 0)
                        {
                            negativeNumbers = negativeNumbers + number + ",";
                        }
                        
                        result = number + result;


                    }
                   

        } 

                    if (negativeNumbers != "")
                    {
                        negativeNumbers = negativeNumbers.Substring(0,negativeNumbers.Length - 1);
                        throw new InvalidOperationException("negative not allowed: " + negativeNumbers);
                    }
                
                return result;



              }
              
            
            

            
        
    }
}
