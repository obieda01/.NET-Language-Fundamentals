using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */
            int numOfBirds = 4;
            int numObirdsFlies = 1;
            int numOfBirdsLeft = numOfBirds - numObirdsFlies;
            Console.WriteLine(" 1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on the branch ? " +numOfBirdsLeft);

            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */
            int numOfBirds_2 = 6;
            int numOfNests = 3;

            int numOfBirdsLeft_2 = numOfBirds_2 - numOfNests;
            Console.WriteLine("2. There are 6 birds and 3 nests. How many more birds are there than nests ? " + numOfBirdsLeft_2);


            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */
            int numOfRaccoons = 3;
            int numOfRaccoonsHome= 2;

            int numOfRaccoonsLeft = numOfRaccoons - numOfRaccoonsHome;


            Console.WriteLine("\n \n 3 raccoons are playing in the woods. 2 go home to eat dinner. How many raccoons are left in the woods ? "
                + numOfRaccoonsLeft);


            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */

            int numOfFlowers = 5;
            int numOfBees= 3;

            int numOfLessBees = numOfFlowers - numOfBees;
            Console.WriteLine("\n 4. How many less bees than flowers? " + numOfLessBees);



            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */
            int numOfPigeonBefore = 1;
            int numOfPigeonAfter = 1;
            int totalNumOfPigeon = numOfPigeonBefore + numOfPigeonAfter;

            Console.WriteLine("\n 5. How many pigeons are eating breadcrumbs now? " + totalNumOfPigeon);

            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 

            */
            int numOfOwlFence = 3;
            int numOfOwlJoin = 2;
            int totalNumOfOwl = numOfOwlFence + numOfOwlJoin;

            Console.WriteLine("\n 6.How manyowls are on the fence now ?" + totalNumOfOwl);


            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */

            int numOfBeaversHome = 2;
            int numOfBeaverOut = 1;
            int numOFBeaverLeft = numOfBeaversHome - numOfBeaverOut;
            Console.WriteLine("\n 7. Answer= " + numOFBeaverLeft);

            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */

            int numOfToucansTree = 2;
            int numOfToucanJoin = 1;
            int totalNumOfToucan = numOfToucansTree + numOfToucanJoin;
            Console.WriteLine("\n 8. Answer= " + totalNumOfToucan);

            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */

            int numOfSqui = 4;
            int numOfNuts = 2;
            int numOfSquMore = numOfSqui - numOfNuts;
            Console.WriteLine("\n 9. Answer= " + numOfSquMore);

            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */
            double numOfQua = 1;
            double numOfDime = 1;
            double numOfNickels = 2;

            double totalMoney = (numOfQua * 0.25) + (numOfDime * 0.1) + (numOfNickels*0.05);

            Console.WriteLine("\n 10. answer = total money =  " + totalMoney);

            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */

            int numOfMuffins_Brier = 18;
            int numOfMuffins_Mac = 20;
            int numOfMuf_Flan = 17;

            int totalNumFirstGrade = numOfMuffins_Brier + numOfMuffins_Mac + numOfMuf_Flan;
            Console.WriteLine("\n 11. Answer= " + totalNumFirstGrade);

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double costOfYoyo = 0.24;
            double costOfWhis = 0.14;

            double totalCost = costOfWhis + costOfYoyo;
            Console.WriteLine("\n 12. answer=" + totalCost);
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int inchOfSnow_Hilt = 29;
            int inchOfSnow_School = 17;

            int diffInchesOfSnow = inchOfSnow_Hilt - inchOfSnow_School;

            Console.WriteLine("\n 14. answer=" + diffInchesOfSnow);
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int spendOnToy = 3;
            int spendOnPencil = 2;
            int moneyHilt = 10;

            int moneyHiltLeft = moneyHilt - (spendOnPencil+spendOnToy);

            Console.WriteLine("\n 15.answer= "+moneyHiltLeft);

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int totalMarbels = 16;

            int lostMarbels = 7;

            int numOfMarbelsLeft = totalMarbels - lostMarbels;

            Console.WriteLine("\n 16.answer= "+ numOfMarbelsLeft);

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int seahellMegan = 19;
            int seahellTotal = 25;

            int seahellNeeded = seahellTotal - seahellMegan;
            Console.WriteLine("\n 17.answer = "+seahellNeeded);
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int totalBalloon = 17;

            int redBalloon = 8;

                int greenBalloon = totalBalloon - redBalloon;
            Console.WriteLine("\n 18.answer ="+greenBalloon);
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int bookOnShelf = 38;
            int bookAdded = 10;
            int totalBook = bookOnShelf + bookAdded;

            Console.WriteLine("\n19.answer =" + totalBook);

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int numOfLegBee = 6;
            int numOfBees_20 = 8;
            int totalNumOfLegs = numOfLegBee * numOfBees_20;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double iceConeCost = 0.99;
            int numOfCones = 2;

            double totalIceCost = (double)numOfCones * iceConeCost;
            Console.WriteLine("\n 21. answer = " + totalIceCost);

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int currentRockNum = 125;
            int avaRockNum = 64;

            int neededRockNum = currentRockNum - avaRockNum;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int timeSpendMor = (1 * 60) + 30;
            int timeSpendAft = 45;

            int totalTime = timeSpendAft + timeSpendMor;
            Console.WriteLine("\n\n 25. answer =" + totalTime/60 +"Hours "+totalTime%60+"minutes");
            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int hotdogNum = 6;
            double hotdogCost = 0.50;

            double totalCost_26 = hotdogCost * hotdogNum;

            Console.WriteLine("\n 26.answer =" + totalCost_26);

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            double hiltMoney = 0.5;
            double pencilCost = 0.07;

            int numBuy = (int)(hiltMoney / pencilCost);

            Console.WriteLine("\n 27. answer=" + numBuy);
            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int totalNumButter = 33;
            int numOfOrangeButter = 20;

            int numOfRedButter = totalNumButter - numOfOrangeButter;

            Console.WriteLine("\n 28.answer= " + numOfRedButter);

            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double giveMoney = 1.00;
            double candyCost = 0.54;
            double changeLeft = giveMoney - candyCost;

            Console.WriteLine("\n 29.answer =" +changeLeft);
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int numOfTrees = 13;
            int addedTrees = 12;
            int totalTrees = numOfTrees + addedTrees;
            Console.WriteLine("\n 30. answer="+totalTrees);

            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int numOfDays = 2;
            int numOfHours = numOfDays * 24;
            Console.WriteLine("\n 31.answer ="+numOfHours);


            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numOfCousins = 4;
            int numOfGum = 5;
            int numOfGumNeeded = numOfCousins * numOfGum;

            Console.WriteLine("\n 32.answer=" + numOfGumNeeded);
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double danMoney = 3.00;
            double candyBar = 1.00;

            double moneyLeft = danMoney -candyBar;
            Console.WriteLine("\n\n 33.answer =" + moneyLeft);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numOfBoats = 5;
            int numOfPplEach =  3;
            int totalNumOfPpl = numOfBoats * numOfPplEach;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int legosEllen = 380;
            int legosLost = 57;
            int totalLegosLeft = legosEllen - legosLost;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int bakedMuffins = 35;
            int totalMuffinsNeeded = 83;

            int moreMuffinsNeeded = totalMuffinsNeeded - bakedMuffins;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int numOfCrayons_Willy = 1400;
            int numOfCrayons_Lucy = 290;
            int numOfCrayons_LucyMore = numOfCrayons_Willy - numOfCrayons_Lucy;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int numOfStickerEachPage = 10;
            int numOfPages = 22;
            int totalOfsticker = numOfStickerEachPage * numOfPages;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int numOfCupcake = 96;
            int numOfChild = 8;
            int totalCakeShare = numOfCupcake / numOfChild;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int numOfGinger = 47;
            int numOfGingerEachJar = 6;
            int numOfGingerLeft = numOfGinger % numOfGingerEachJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int numOfCroissant = 59;
            int numOfNeigh = 8;

            int numOfCroissanLeft = numOfCroissant % numOfNeigh;
            Console.WriteLine("\n\n 41. answer ="+numOfCroissanLeft);
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int numOfOatmeal = 276;
            int numOfCookiesEachTray = 12;
            int numOfTray = (numOfOatmeal / numOfCookiesEachTray) + 1;
            Console.WriteLine("\n\n 42. answer =" +numOfTray);

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int numOfBitePre = 480;
            int numOfPret = 12;
            int numOfBitePreNeeded = 480 / 12;
            Console.WriteLine("\n\n 43. answer= " + numOfBitePreNeeded);
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int numOfLemon = 53;
            int numOfLemonLeft = 2;
            int numOfLemonEachBox = 3;
            int numOfBoxes = (numOfLemon - numOfLemonLeft) / numOfLemonEachBox;
            Console.WriteLine("\n\n 44. answer ="+numOfBoxes);
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int numOfCaStick = 74;
            int numOfPplServed = 12;
            int numOfCaLeft = numOfCaStick % numOfPplServed;
            Console.WriteLine("\n\n 45.answer ="+numOfCaLeft);

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numOfTedBears = 98;
            int maxOfTedShelf = 7;
            int numOfShelfNeeded = numOfTedBears / maxOfTedShelf;

            Console.WriteLine("\n\n 46. answer = " + numOfShelfNeeded);
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int numOfPicEachAlbum = 20;
            int numOfPics = 480;
            int numOfAlbumNeeded = (numOfPics / numOfPicEachAlbum) + 1;

            Console.WriteLine("\n\n 47. answer =" + numOfAlbumNeeded);



            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int numOfTradCards = 94;
            int maxOfCardsEachBox = 8;
            int numOfCardsLeft = numOfTradCards % maxOfCardsEachBox;

            Console.WriteLine("\n\n 48. answer =" + numOfCardsLeft);
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int numOfBooks = 210;
            int numOfShelves = 10;

            int numOfBooksEachShelf = numOfBooks / numOfShelves;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            int numOfBakedCro = 17;
            int numOfGuests = 7;

            int numOfCroEach = numOfBakedCro / numOfGuests;
            Console.WriteLine("\n\n 50. answer=" + numOfCroEach);
        }
    }
}
