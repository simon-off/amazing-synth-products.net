const requiredInputs = document.querySelectorAll("[data-val-required]");
const regexInputs = document.querySelectorAll("[data-val-regex]");

function validateRequired(input) {
  if (!input.value) return input.dataset.valRequired;
}

function validateRegex(input) {
  const regex = new RegExp(input.dataset.valRegexPattern);
  if (!regex.test(input.value)) return input.dataset.valRegex;
}

function validateInputs(inputs, validationCallback) {
  for (let input of inputs) {
    input.addEventListener("input", () => {
      const span = document.querySelector(`[data-valmsg-for="${input.id}"]`);
      span.textContent = validationCallback(input);
    });
  }
}

validateInputs(requiredInputs, validateRequired);
validateInputs(regexInputs, validateRegex);
