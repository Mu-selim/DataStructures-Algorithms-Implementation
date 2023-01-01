/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    nums.sort((a, b) => {
        return a-b;
    });
    let n = nums.length;
    let max = 0, count = 0, slow = 0, fast = 0, majorityItem = nums[0];
    for(let i = 0; i <= n; i++) {
        if(nums[slow] === nums[fast]) {
            count += 1;
            if(count > max) {
                max = count;
                majorityItem = nums[fast];
            }
            fast += 1;
        } else {
            slow = fast;
            count = 0;
        }
    }
    return majorityItem;
};

console.log(majorityElement(nums = [3,2,3]));
console.log(majorityElement(nums = [2,2,1,1,1,2,2]));
console.log(majorityElement(nums = [1]));
console.log(majorityElement(nums = [3,3,4]));