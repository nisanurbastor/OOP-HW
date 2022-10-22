/***********************************************************************************/
/***********                 NİSANUR BAŞTOR                  ***********************/
/***********                   B201202044                    ***********************/
/***********************************************************************************/



namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CRYPT
    {
        public string numberD;
        public int digit1_;
        public int digit2_;
        public int digit3_;
        public int digit4_;
       
        public void inputNumber()
        {
            
            Console.Write("Enter a four-digit number: ");
            
            for(int i=0; i<10; i++)
            {
                numberD = Console.ReadLine();

                if (numberD.Length == 4)
                    break;
                else
                    Console.Write("Enter a four-digit number: ");
                
            }
            
        }

        public void encryptNumber()
        {
             char digit1 = numberD[0];
             char digit2 = numberD[1];
             char digit3 = numberD[2];
             char digit4 = numberD[3];

             digit1_ = ((int)Char.GetNumericValue(digit1) + 7) % 10;
             digit2_ = ((int)Char.GetNumericValue(digit2) + 7) % 10;
             digit3_ = ((int)Char.GetNumericValue(digit3) + 7) % 10;
             digit4_ = ((int)Char.GetNumericValue(digit4) + 7) % 10;
        }
       

        public void printEncryptedNumber()
        {
            encryptNumber();
            Console.Write("Encrypted Message: " + digit3_ + digit4_ + digit1_ + digit2_);
           
                Console.ReadLine();

        }

        public void printDecryptedNumber()
        {

            Console.Write("Decrypted Message: " + numberD);
            Console.ReadLine();
        }


    }

    class Program
    {
       
        
        static void Main(string[] args)

        {

            CRYPT output = new CRYPT();
            output.inputNumber();
            output.printEncryptedNumber();
            output.printDecryptedNumber();

        
       }
    }
}
