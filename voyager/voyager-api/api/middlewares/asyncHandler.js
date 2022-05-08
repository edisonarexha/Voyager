// Middleware that is used to handle async tasks, so we avoid having to use excessive try/catch blocks.
const asyncHandler = (fn) => {
  return (request, response, next) => {
    fn(request, response, next).catch(next);
  };
};

// Exports of this file.
module.exports = asyncHandler;
