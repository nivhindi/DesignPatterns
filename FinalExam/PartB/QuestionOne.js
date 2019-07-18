function FindTheSingleNumber(array) {
	let allNumbersSet = new Set();
	let singleNumberSet = new Set();
	for (let singleNum of array) {
        if (allNumbersSet.has(singleNum)) {
            singleNumberSet.delete(singleNum);
		} else {
            allNumbersSet.add(singleNum);
            singleNumberSet.add(singleNum);
		}
	}
	
    return singleNumberSet.values().next().value;
}