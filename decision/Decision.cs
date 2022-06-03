using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Numerics;
using System.Windows;

namespace sort_search_algorithm.decision
{
    public static class Decision
    {
        /// <summary>
        /// 素数探索
        /// </summary>
        /// <param name="x">素数か確かめたい数値</param>
        /// <returns>素数か素数以外かの真偽値を返す</returns>
        public static bool IsPrime(int x)
        {
            if (x < 2) return false;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) return false;
            }

            return true;
        }

        /// <summary>
        /// 平方根を使った試行
        /// </summary>
        /// <param name="x">素数か確かめたい数値</param>
        /// <returns>素数か素数以外かの真偽値を返す</returns>
        public static bool IsPrimeRoot(int x)
        {
            if (x <2) return false;

            double spr = Math.Sqrt(x);

            // 2< i <spr(√x)
            for (int i = 2; i <=spr; i++)
            {
                if (x % i == 0) return false;
            }
            
            return true;
        }
        
        /// <summary>
        /// エラトステネスを使ってみる
        /// </summary>
        /// <param name="x">素数か確かめたい数値</param>
        /// <returns>素数か素数以外かの真偽値を返す</returns>
        public static bool Eratosthenes(int x)
        {
            
            if (x <2) return false;
            else if (x == 2) return true;
            else if (x % 2 == 0) return false;
            
            
            double spr = Math.Sqrt(x);
            //2の倍数を除く
            int add = 2;
            
            // 2< i <spr(√x)
            for (int i = 2; i <=spr; i+=add)
            {
                if (x % i == 0) return false;
            }

            return true;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool[] EratosthenesArray(int x)
        {
            var isPrime = new bool[x+1];
            isPrime[0] = isPrime[1] = false;
            
            for (int i = 2; i <= x; i++)
            {
                isPrime[i] = true;
            }
            
            for (int i = 2; i <= x; i++)
            {
                //ふるい落とされていたらスルー
                if (!isPrime[i]) continue;
                
                //ふるいにかけて倍数を外す
                for (int j = i * 2; j <= x; j += i)
                {
                    isPrime[j] = false;
                }
            }
            
            return isPrime;
        }
        
    }
}