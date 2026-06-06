function sumDigits(num) {
    let sum = 0;
    let numAsStr = String(num);

    for (let char of numAsStr) {
        let digit = Number(char);
        sum += digit;
    }

    console.log(sum);
}

sumDigits(245678)