import Joi from "joi";

const schema = Joi.object().keys({
  email: Joi.string().email().min(5).max(25).required(),
  password: Joi.string().min(5).max(12).required(),
});

export default schema;
