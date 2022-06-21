import Joi from "joi";

const aboutSchema = {
  validateAboutId: {
    params: Joi.object({
      aboutId: Joi.string()
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
      descriptionSecond: Joi.string().required(),
      description: Joi.string().required(),
    }),
  },
  put: {
    body: Joi.object({
      _id: Joi.string()
        .regex(/^[0-9a-fA-F]{24}$/)
        .required(),
      descriptionSecond: Joi.string().required(),
      description: Joi.string().required(),
    }),
  },
};

export default aboutSchema;