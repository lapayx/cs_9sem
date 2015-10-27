using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_3_Evclid
{
    public static class Evclid
    {
        private static int calc(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }
        public static int Calculate(int a, int b, params int[] other)
        {

            int res = calc(a, b);
            foreach (int x in other)
            {
                res = calc(res, x);
            }
            return res;

        }
        public static int CalculateFromTime(int a, int b, out long time )
        {
            DateTime start = DateTime.Now;
            int res = calc(a, b);
            DateTime end = DateTime.Now;
            time = (end.Ticks - start.Ticks)/1000;
            return res;

        }

        public static int CalculateBinaryFromTime(int a, int b, out long time)
        {
            DateTime start = DateTime.Now;
            int res = gcd(a, b);
            DateTime end = DateTime.Now;
            time = (end.Ticks - start.Ticks) / 1000;
            return res;

        }
        static int   gcd(int u, int v)
        {
            int shift;

            /* GCD(0,v) == v; GCD(u,0) == u, GCD(0,0) == 0 */
            if (u == 0) return v;
            if (v == 0) return u;

            /* Let shift := lg K, where K is the greatest power of 2
                  dividing both u and v. */
            for (shift = 0; ((u | v) & 1) == 0; ++shift)
            {
                u >>= 1;
                v >>= 1;
            }

            while ((u & 1) == 0)
                u >>= 1;

            /* From here on, u is always odd. */
            do
            {
                /* remove all factors of 2 in v -- they are not common */
                /*   note: v is not zero, so while will terminate */
                while ((v & 1) == 0)  /* Loop X */
                    v >>= 1;

                /* Now u and v are both odd. Swap if necessary so u <= v,
                   then set v = v - u (which is even). For bignums, the
                   swapping is just pointer movement, and the subtraction
                   can be done in-place. */
                if (u > v)
                {
                    int t = v; v = u; u = t;
                }  // Swap u and v.
                v = v - u;                       // Here v >= u.
            } while (v != 0);

            /* restore common factors of 2 */
            return u << shift;
        }
    }
}
