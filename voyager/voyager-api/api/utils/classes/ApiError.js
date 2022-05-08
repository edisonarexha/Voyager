// Class that is used to represent errors in our API.
class ApiError extends Error {
  constructor(message, statusCode) {
    super(message);
    this.statusCode = statusCode;

    Error.captureStackTrace(this, ApiError);
  }
}

// Exports of this file.
module.exports = ApiError;
