/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function(strs) {
    let ans = [strs[0]], n = strs.length, firstLen = strs[0].length;
    for(let i = 1; i < n; i++) {
        let temp = '', min = Math.min(firstLen, strs[i].length);
        for(let j = 0; j < min; j++) {
            if(ans[0][j] !== strs[i][j])
                break;
            temp += ans[0][j];
        }
        ans.push(temp);
    }
    ans = Array.from(ans).sort();
    return ans[0];
};

console.log(longestCommonPrefix(strs = ["flower","flow","flight"]));
console.log(longestCommonPrefix(strs = ["dog","racecar","car"]));
console.log(longestCommonPrefix([""]));
console.log(longestCommonPrefix(["a"]));