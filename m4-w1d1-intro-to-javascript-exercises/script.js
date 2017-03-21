window.onload = function() {

    console.log("************************");
    console.log(SumDouble(1, 2));
    console.log(SumDouble(3, 3));
    console.log(SumDouble(4, 3));
    console.log(SumDouble(2, 3));

    function SumDouble(one, two) {
        if (one === two) {
            return (one + two) * 2;
        } else {
            return one + two;
        }
    }

    console.log("************************");
    console.log(hasTeen(13, 20, 10)); // → true
    console.log(hasTeen(20, 19, 10)); // → true
    console.log(hasTeen(20, 10, 13)); // → true
    console.log(hasTeen(20, 10, 11)); // → true

    function hasTeen(one, two, three) {
        if (one >= 13 && one <= 19 || two >= 13 && two <= 19 || three >= 13 && three <= 19) {
            return true;
        }
        return false;
    }
    console.log("************************");
    console.log("lastDigit");
    console.log(lastDigit(7, 17)); // → true
    console.log(lastDigit(6, 17)); //→ false
    console.log(lastDigit(3, 113)); // → true
    function lastDigit(one, two) {
        if (one % 10 === two % 10) {
            return true;
        }
        return false;
    }
    console.log("************************");
    console.log("seeColor");
    console.log(seeColor("redxx")); //→ "red"
    console.log(seeColor("xxred")); //→ ""
    console.log(seeColor("blueTimes")); // → "blue"
    function seeColor(str) {
        var redValue = str.substring(0, 3);
        var blueValue = str.substring(0, 4);
        if (redValue === ("red")) {
            return redValue;
        } else if (blueValue === "blue") {
            return blueValue;
        } else {
            return "";
        }
    }
    console.log("************************");
    console.log(middleThree("Candy")); // → "and"
    console.log(middleThree("and")); //→ "and"
    console.log(middleThree("solving")); // → "lvi"
    console.log(middleThree("ssolvingg")); // → "lvi"
    console.log(frontAgain(2)); //→ true
    console.log(frontAgain(null)); //→ true

    function middleThree(str) {
        if (!isNaN(str) || str === null) return false;
        if (str.length <= 3) {
            return str;
        } else {
            return str.substring((str.length / 2) - 1, (str.length / 2) + 2);
        }
    }
    console.log("************************");
    console.log(frontAgain("edited")); // → true
    console.log(frontAgain("edit")); // → false
    console.log(frontAgain("ed")); //→ true
    console.log(frontAgain(2)); //→ true
    console.log(frontAgain(null)); //→ true

    function frontAgain(str) {
        if (!isNaN(str) || str === null) return false;
        if (str.substring(0, 1) === str.substring(str.length - 2, str.length - 1)) { return true; } else { return false; }
    }

    console.log("************************");
    console.log(makeMiddle([1, 2, 3, 4])); // → [2, 3]
    console.log(makeMiddle([7, 1, 2, 3, 4, 9])); // → [2, 3]
    console.log(makeMiddle([1, 2])); // → [1, 2]
    console.log(makeMiddle([5])); // → [1, 2]
    console.log(makeMiddle(["r"])); // → [1, 2]

    function makeMiddle(nums) {
        if (makeMiddle.length < 2) {
            return nums;
        }
        return [nums[(nums.length / 2) - 1], nums[(nums.length / 2)]];
    }


    // console.log(makeMi)ddle([1, 2, 3, 4])); // → [2, 3]
    // console.log(makeMiddle([7, 1, 2, 3, 4, 9])); // → [2, 3]
    // console.log(makeMiddle([1, 2])); // → [1, 2]

    // function makeMiddle(numbers) {
    //     for (var i = 0; i < numbers.length; i++) {
    //         return numbers[i];
    //     }
    // }
}