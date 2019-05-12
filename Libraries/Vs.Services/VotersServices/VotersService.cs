using System;
using System.Collections.Generic;
using System.Text;

namespace Vs.Services.VotersServices
{
   public class VotersService
    {
        //R: The recipient, voter


        /*Register phase  ?between B & R (Local government and Voter)
          check if it is correct phase before proceeding

        HR = H(pw)
        reg=(id, pn, HR)^eB mod NB

        <------------ reg



        ---------------->Cert(R)
        sB^eB mod NB == H(pn, eB)

        */



        /*Circling phase ?between B & R (Local government and Voter)
          check if it is correct phase before proceeding

        <----------------------- send login request
        -------------------------> r
        HR` = H(H(pw), r)
        v elementR Zq*, c = g^v * h^-b mod p (mb element {m1, m2,......mn})
        <--------------------- (pn, HR`, c)


        -----------------------> (ei`, si`), 1 <=i <=n

        yp = yp`* yB mod p
        where i= 1,2, ..... n

        di = c(gh)i mod p
        ei` == H(mi, pn, g^si` * yp^ei` * di mod p)
        e= eb`
        s = sb` + v + b mod q
        
        O(mb) = (e,s)  //O stands for rho
       






        */



        /*voting phase ?between R & V (voter and verifier(ballot))
          check if it is correct phase before proceeding

        CR = E.H(H(pw),eb)(mb, O(mb))
        ----------------------------->(Cert(R), CR)

        */

    }
}
