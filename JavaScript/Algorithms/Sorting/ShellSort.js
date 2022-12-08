let array = [1, 20, -12, 4, 1, -5, 14, 12];

const shellSort = (array) => {
    let length = array.length;
    for(let gap = Math.floor(length/2); gap >= 1; gap /= 2) {
        let i = 0;
        for(let j = i+gap; j < length; j++ && i++) {
            if(array[i] > array[j]) {
                [array[i], array[j]] = [array[j], array[i]];
            }
        }
    }
    return array;
}

console.log(array);
console.log(shellSort(array));