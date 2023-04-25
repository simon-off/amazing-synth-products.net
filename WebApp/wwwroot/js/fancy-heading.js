const elements = document.querySelectorAll(".fancy-heading");

for (let element of elements) {
  let styleArray = [];
  for (let i = 1; i < 20; i++) {
    styleArray.push(`${element.innerHTML.length * i}ch 0 var(--color)`);
    styleArray.push(`-${element.innerHTML.length * i}ch 0 var(--color)`);
  }
  element.style.textShadow = styleArray.join(",");
}
