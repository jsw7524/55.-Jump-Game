using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.Jump_Game
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            if (null == nums)
            {
                return false;
            }
            int maxDistance= 0;
            for (int i=0;i< nums.Length-1 && maxDistance < nums.Length&& i<=maxDistance; i++)
            {
                if (maxDistance < i + nums[i])
                {
                    maxDistance = i + nums[i];
                }
            }
            if (maxDistance+1 >= nums.Length)
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            (new Solution()).CanJump(new int[] {0, 2, 3});
        }
    }
}
