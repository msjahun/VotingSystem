using System;
using System.Collections.Generic;
using System.Text;

namespace Vs.Services.BallotServices
{
   public class BallotService
    {
        //V: The verifier, ballot

        /*voting phase ?between R & V (voter and verifier(ballot))
          check if it is correct phase before proceeding


        ---------------------> (Cert(R), CR)
         sB^eB mod NB == H(pn, eB)
         publish (Cert(R), CR) in BB



         */


        /*counting phase ?between B & V (local government and verifier(ballot))
          check if it is correct phase before proceeding

        ------------> KeyR 
        (mb, O(mb)) = DkeyR (CR)// I think this stage is decrypt CR using KeyR
        publishes (Cert(R), CR, mb, keyR) in BB

        yp = yp`*yB mod p
        e== H(mb, pn, g^s * yp^e mod p)
        the ballot is counted

        */
    }
}
