const insertionSort = (array) => {
    const len = array.length;
    for(let i = 1; i < len; i++) {
        let key = array[i];
        j = i-1;
        while(j >= 0 && array[j] > key) {
            array[j+1] = array[j];
            j -= 1;
        }
        array[j+1] = key;
    }
    return array;
}

console.log(insertionSort([1, 5, 4, 7, -1, 1, 0, -5, 9, 6]));