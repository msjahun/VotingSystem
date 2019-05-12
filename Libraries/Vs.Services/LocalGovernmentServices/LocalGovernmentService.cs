using System;
using System.Collections.Generic;
using System.Text;

namespace Vs.Services.LocalGovernmentServices
{
    public class LocalGovernmentService
    {

        //B : proxy signer, Local government



        /*proxy phase ?between A & B (Central government and local government)
         check if it is correct phase before proceeding


        --------> dlgA,B

            g^sA == rA*yA^rA mod p
            if correct,

            sA,B = H(g^sA mod p)^dB mod NB
            sp = sA + xB mod q

        <-------------- sA,B

         */





        /*Register phase ?between B & R (Local government and Voter)
        check if it is correct phase before proceeding

        <------------------ reg
          (id, pn, HR) =reg ^dB mod NB
          if id is valid
          store(pn, HR) in system database
          flag (pn) =0
          KeyR = H(HR, eB)
          sB = H(pn, eB)^dB mod NB
          Cert(R) = (pn, eB, sB)
          publishes Cert(R), H(KeyR) in BB

        ----------------------> Cert(R)



        */



        /*Circling phase ?between B & R (Local government and Voter)
         check if it is correct phase before proceeding


        <-------------- login request
         r elementR Zq*
         -----------------------> r

        <------------------------(pn, HR`, c)
         HR` == H(HR, r)
         flag(pn)==0
         ki elementR Zq*, where i =1,2,.....,n
         ki = g^ki mod p
         di = c(gh)^i mod p
         ei` = H(mi, pn, ki*di, mod p)
         si` = ki - sp*ei` mod q
         set flag(pn) =1

        ---------------------------> (ei`, si`), 1 <= i <= n


         */


        /*counting phase ?between B & V (local government and verifier(ballot))
         check if it is correct phase before proceeding


        ------------------> KeyR //sends key


         */
    }
}
