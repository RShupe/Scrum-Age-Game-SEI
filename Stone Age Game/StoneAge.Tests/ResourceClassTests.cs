using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Stone_Age_Game;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	File Name:                      ResourceClassTests.cs
//	Description:                    This class is used to do unit testing on the resource classes
//	Author:                         Ryan Shupe, East Tennessee State University
//  Email:                          shuper@etsu.edu
//  Last Modified By:               Ryan Shupe
//	Created:                        Saturday November 15, 2020
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace StoneAge.Tests
{
    public class ResourceClassTests
    {
        private readonly Money money;
        private readonly Prototypes prototype;
        private readonly UseCases usecase;
        private readonly UserStories userstory;

        public ResourceClassTests()
        {
            money = new Money();
            prototype = new Prototypes();
            usecase = new UseCases();
            userstory = new UserStories();
        }

        //check gather methods with 1 developer
        [Fact]
        public void TestGatherMoney()
        {
            int result = money.Gather(1);
            Assert.True(RangeTest(result, 1));
        }
        [Fact]
        public void TestGatherPrototype()
        {
            int result = prototype.Gather(1);
            Assert.True(RangeTest(result, 1));
        }
        [Fact]
        public void TestGatherUseCase()
        {
            int result = usecase.Gather(1);
            Assert.True(RangeTest(result, 1));
        }
        [Fact]
        public void TestGatherUserStory()
        {
            int result = userstory.Gather(1);
            Assert.True(RangeTest(result, 1));
        }


        public bool RangeTest(int input, int numDevelopers)
        {
            if (numDevelopers == 1)
            {
                if (input < 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        }
}
