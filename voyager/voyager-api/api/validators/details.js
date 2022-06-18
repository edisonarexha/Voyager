import Joi from "joi";

const detailsSchema = {
  validateDetailsId: {
    params: Joi.object({
      detailsId: Joi.string()
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
      email: Joi.string().required(),
      phone: Joi.string().required(),
      address: Joi.string().required(),
      website: Joi.string().required(),
    }),
  },
  put: {
    body: Joi.object({
      _id: Joi.string()
        .regex(/^[0-9a-fA-F]{24}$/)
        .required(),
        email: Joi.string().required(),
        phone: Joi.string().required(),
        address: Joi.string().required(),
        website: Joi.string().required(),
    }),
  },
};

export default detailsSchema;