/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var backspaceCompare = function(s, t) {
    let stackS = [], stackT = [];
    while(s.length > 0) {
        if(s[0] === '#') {
            stackS.pop();
        } else {
            stackS.push(s[0]);
        }
        s = s.replace(s[0], '');
    }

    while(t.length > 0) {
        if(t[0] === '#') {
            stackT.pop();
        } else {
            stackT.push(t[0]);
        }
        t = t.replace(t[0], '');
    }

    return stackS.toString() == stackT.toString();
};

console.log(backspaceCompare(s = "ab#c", t = "ad#c"));
console.log(backspaceCompare(s = "ab##", t = "c#d#"));
console.log(backspaceCompare(s = "a#c", t = "b"));