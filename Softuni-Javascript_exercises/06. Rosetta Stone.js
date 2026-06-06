function rosettaStone(input) {
    let templateRows = Number(input[0]);
    let template = input.slice(1, templateRows + 1).map(row => row.split(' ').map(Number));
    let message = input.slice(templateRows + 1).map(row => row.split(' ').map(Number));

    let templateRowsCount = template.length;
    let templateColsCount = template[0].length;

    let alphabet = ' ABCDEFGHIJKLMNOPQRSTUVWXYZ';

    let result = '';

    for (let r = 0; r < message.length; r++) {
        for (let c = 0; c < message[r].length; c++) {
            let templateValue = template[r % templateRowsCount][c % templateColsCount];
            let sum = message[r][c] + templateValue;
            let charIndex = sum % 27;
            result += alphabet[charIndex];
        }
    }

    console.log(result.trim());
}
rosettaStone([
  '2',
  '59 36',
  '82 52',
  '4 18 25 19 8',
  '4 2 8 2 18',
  '23 14 22 0 22',
  '2 17 13 19 20',
  '0 9 0 22 22'
]);
