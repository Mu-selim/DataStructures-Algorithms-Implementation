/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
    for(let i = 0; i < nums.length; i++) {
        if(i === nums.lastIndexOf(nums[i])) {
            return nums[i];
        } else {
            nums.splice(nums.lastIndexOf(nums[i]), 1);
        }
    }
};

console.log(singleNumber(nums = [2,2,1]));
console.log(singleNumber(nums = [4,1,2,1,2]));
console.log(singleNumber(nums = [1]));
console.log(singleNumber(nums = [1,0,1]));