import Joi from "joi";

const contactsSchema = {
  validateContactId: {
    params: Joi.object({
      contactId: Joi.string()
        .regex(/^[0-9a-fA-F]{24}$/)
        .required(),
    }),
  },
  validateId: {
    params: Joi.object({
      id: Joi.string()
        .regex(/^[0-9a-fA-F]{24}$/)
        .required(),
    }),
  },
  post: {
    body: Joi.object({
      name: Joi.string().required(),
      message: Joi.string().required(),
      email: Joi.string().required(),
      subject: Joi.string().required(),
    }),
  },
  put: {
    body: Joi.object({
      _id: Joi.string()
        .regex(/^[0-9a-fA-F]{24}$/)
        .required(),
        name: Joi.string().required(),
        message: Joi.string().required(),
        email: Joi.string().required(),
        subject: Joi.string().required(),
    }),
  },
}

export default contactsSchema;
