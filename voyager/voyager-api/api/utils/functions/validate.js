// Imports: third-party packages.
const { validate } = require("express-validation");

// Function that is used to wrap around express-validation's validate with certain options passed automatically.
const validateSchema = (schema) => {
  return validate(
    schema,
    { keyByField: true, context: true },
    { abortEarly: false, allowUnknown: false }
  );
};

// Exports of this file.
module.exports = validateSchema;
