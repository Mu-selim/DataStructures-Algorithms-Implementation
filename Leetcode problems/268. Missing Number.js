/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function(nums) {
    let n = nums.length;
    nums.sort((a, b) => {
        return a - b;
    });
    for(let i = 0; i < n; i++) {
        if(i !== nums[i])
            return i;
    }
    return n;
};

console.log(missingNumber(nums = [3,0,1]));
console.log(missingNumber(nums = [0,1]));
console.log(missingNumber(nums = [9,6,4,2,3,5,7,0,1]));