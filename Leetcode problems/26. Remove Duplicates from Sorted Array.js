/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    let n = nums.length,
        last = NaN,
        count = 0;
    for(let i = 0; i < n; i++) {
        if(nums[i] !== last) {

            // We will update the array in place
            nums[count] = nums[i];
            last = nums[i];
            count += 1;
        }
    }
    return count;
};

console.log(removeDuplicates(nums = [1,1,2]));
console.log(removeDuplicates(nums = [0,0,1,1,1,2,2,3,3,4]));