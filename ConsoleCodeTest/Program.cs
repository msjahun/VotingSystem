using System;
using System.Security.Cryptography;
using System.Text;
using ConsoleCodeTest.Descrypto;
using ConsoleCodeTest.Utilities;
namespace ConsoleCodeTest
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Program start");


            int p, q, pB, qB;
            int g, h;
            int xA, xB;

            //these should be picked at random
            p = pB = 11;
            q = qB = 5;
            Console.WriteLine("Value of p, pB ={0}, q, qB={1}", p, q);


            g = 9; h = 5;
            Console.WriteLine("Value of g={0}, h={1}", g, h);


            //these should be picked from a range at random
            xA = 2; xB = 4;
            Console.WriteLine("Value of xA={0}, xB{1}", xA, xB);


            //calculated currectly
            double yA = Math.Pow(g, xA) % p;
            Console.WriteLine("Value of yA=({0} ^{1}) %{2} ={3}", g, xA, p, yA);

            double yB = Math.Pow(g, xB) % p;
            Console.WriteLine("Value of yB=({0} ^{1}) %{2} ={3}", g, xB, p, yB);


            int NB = pB * qB;
            Console.WriteLine("Value of NB={0}", NB);


            int EulNB = (pB - 1) * (qB - 1);
            Console.WriteLine("Value of EulNB=({0}-1)*({1}-1)={2}", pB, qB, EulNB);

            //proxy B choses eB such that GCD(eB, EulNB)==1
            int eB = 0;
            for (int i = 1; i <= EulNB; i++)
            {
                Console.WriteLine("i={0} eB={1}, GCD={2}", i, eB, Common.GCD(i, EulNB));
                if (Common.GCD(i + 1, EulNB) == 1)
                {
                    eB = i + 1;
                    break;
                }
                eB = 1;
            }

            Console.WriteLine("The value of eB={0}", eB);


            // double dB = (eB ^ (-1)) % NB;
            double dB = EulNB - eB; //big error in this part

            Console.WriteLine("The value of dB={0}", dB);



            Console.WriteLine("Proxy phase design********************************");
            int k = 3;

            double sP, sAB;
            double rA = Math.Pow(g, k) % p;
            double sA = (xA * rA) + k % q;
            //encrypts rA and sA and forwards it to B

            double ypPrime = Math.Pow(g, sA) % p;
            //publishes xpPrime to BB

            //On the proxy B service
            //receives rA, Sa

            //Decrypts using dB, NB
            double gSA = Math.Pow(g, sA); //doesn't give me desired value
            double tempVAlue = (rA * Math.Pow((yA), rA)) % p; // is totally correct, two statements should be inside ifcondition
            if (true)
            {
                //true
                //accepts proxy

                sP = sA + xB % q;
                string toHash = (Math.Pow(g, sA) % p).ToString();
                //proxy generates signature
                sAB = Math.Pow((Common.H(toHash)), dB) % NB; //lets assume this is correct



                //back at a
                double hashyprime = Common.H(ypPrime.ToString()) % NB;
                double tempSecondValue = Math.Pow(sAB, eB) % NB;

                //because our hash function is giving issues our condition is wrong... so
                if (Math.Pow(sAB, eB) % NB == hashyprime)
                {
                    //condition successful
                    //publish ypPrime, yB in BB
                }
            }




            Console.WriteLine("*****Register phase*****Enter");

            string pn = "Musa";
            string pw = "pass";

            double hR = Common.H(pw);

            //encrypts(id,pn,H(pw)) using (dB,NB) and check if R is a legal user
            //if so, B stores(pn,hR) in system database and sets flag(pn)=0

            double keyR = Common.H(hR.ToString() + eB.ToString());
            double sB = Math.Pow(Common.H(pn+eB.ToString()),dB)% NB;
            string CertR = pn + eB.ToString() + sB.ToString();
            //returns Cert(R) to R, publishes Cert(R) to bulletin board, BB
            //where Cert(R) = (pn, eB, sB);

            //R veries RSA signature
            if(Math.Pow(sB, eB) == Common.H(pn + eB.ToString())%NB)
            {//if true R has the right to vote

            }






            //Console.WriteLine("***********Circling phase******");
            //int r=3;
            ////b sends r to R after receiving login request

            //double hrPrime = Common.H(Common.H(pw).ToString()+r.ToString());

            //int v = 2;
            //int c = Math.Pow(g, v) * Math.Pow(h, (-1 * b)) % p;
            //string[] m = { "Donald", "Obama", "Jackson" };

            ////-- forwards (pn, hrPrime, c) to B

            //if (hrPrime == Common.H(hR.ToString() + r))
            //{
            //    //if true

            //    //checks in database flag(pn)==0, if true
            //    //needs to be on the code
            //    double[] d = { 0, 0, 0, 0, 0, 0 }; 
            //    double[] eHat = { 0, 0, 0, 0, 0, 0 }; 
            //    double[] sHat = { 0, 0, 0, 0, 0, 0 }; 
            //  double [] K = { 1,2,3,4,1,2};
            //    for(int i=0; i<K.Length; i++)
            //    {
            //        K[i] = Math.Pow(g, K[i]) % p;

            //        d[i] = (c * Math.Pow(g * h, i))%p;

            //        eHat[i] = Common.H(m[i] + pn + (K[i] * d[i] % p).ToString());

            //        sHat[i] = K[i] - sP * eHat[i] % q;

                       
            //    }
            //    //set flag(pn)=1 on the database
            //    //return (eHat, sHat) 1<=i<=n, to R

            //    Console.WriteLine("*****back at R");


            //   double yp = ypPrime * yB % p;
            //  //  double[] d = { 0, 0, 0, 0, 0, 0 }; //recalculate for B
            //    for (int i=1; i<=n; i++)
            //    {
            //       // d[i] = (c * Math.Pow(g * h, i)) % p; //recalculate for B
            //        if (eHat[i] == Common.H(m[i] + pn + (Math.Pow(g, sHat[i])*Math.Pow(yp,eHat[i])*d[i]%p).ToString()))
            //        {
            //            s = sHat[b] + v + b % q;
            //            e = eHat[b];

            //            sigMb = (s + e);

            //        }
            //    }


            //}




            //Console.WriteLine("*************Voting phase");

           // //Common.H(Common.H(pw)+eB)
           // Math.Pow(sB, eB) == Common.H(pn + eB) % NB;
           // //maybe have a method Cert(R), cR, 
           // //Send BB
           // /


           // Console.WriteLine("***************Counting phase");
           // keyR = Common.H(hR + eB);
           // //CertR(R), cR, mb, keyR)
           // //send to BB 
           // yp = ypPrime * yB % p;

           //if( e == Common.H(mb + pn + Math.Pow(g, s) * Math.Pow(yp, e) % p){

           //     //if yes publish BB

           // }





        }


    }
     
}



//Console.WriteLine("Testing sha1");
//int hashedValue = Common.H("1");
//Console.WriteLine("hash of {0} is {1}", "Musa", hashedValue);



//Console.WriteLine("Testing des encryption decryption");
//var des = new DESAlgorithm();

//string TextToEncrypt = "Hello world";
//string EncryptionKey = "Key1";

//string EncryptedCypher;
//EncryptedCypher = des.Encrypt(TextToEncrypt, EncryptionKey);
//Console.WriteLine("Text to encrypt:{0}, cypertext:{1}",
//    TextToEncrypt, EncryptedCypher);

//Console.Write("Cyptertext:{0}, decryptedTExt:{1}", EncryptedCypher, des.Decrypt(EncryptedCypher, "Key1"));



