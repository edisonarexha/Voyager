import Contact from "../models/Contact";
const asyncHandler = require("../middlewares/asyncHandler");
const { ApiError } = require("../utils/classes");
const { statusCodes } = require("../config");

export default {
  list: asyncHandler(async (req, res) => {
    const list = await Contact.find( {isDeleted: false});
    if (!list) {
      next(new ApiError("Cannot list contacts!", statusCodes.BAD_REQUEST));
      return;
    }
    return res.json(list);
  }),

  get: asyncHandler(async (req, res) => {
    const { id } = req.params;
    const foundItem = await Contact.findOne({ _id: id });
    if (!foundItem) {
      next(new ApiError("Cannot find contact!", statusCodes.BAD_REQUEST));
      return;
    }
    return res.json(foundItem);
  }),

  post: asyncHandler(async (req, res) => {
    const contact = await Contact.create(req.body);
    if (!contact) {
      next(new ApiError("Cannot create contact!", statusCodes.BAD_REQUEST));
      return;
    }
    return res.json(contact);
  }),

  put: asyncHandler(async (req, res) => {
    const contact = req.body;

    const updatedContact = await Contact.findOneAndUpdate(
      {_id: contact._id},
      contact,
      { new: true}
    );


    if (!updatedContact) {
      next(new ApiError("Failed to update contact!", statusCodes.BAD_REQUEST));
      return;
    }
    return res.json(updatedContact);
  }),

  delete: asyncHandler(async (req, res, next) => {
    const { id } = req.params;
    const foundItem = await Contact.findOne({
      _id: id,
      isDeleted: false,
    });

    if(!foundItem) {
      next(new ApiError("Contact not found with id!", statusCodes.NOT_FOUND));
      return;
    }

    const deletedContact = await Contact.findOneAndUpdate(
       { _id: foundItem._id },
       {
         $set: {
           isDeleted: true
         },
       },
       { new: true}
    );
    if(!deletedContact){
      next(new ApiError("Failed to delete contact!", statusCodes.INTERNAL_ERROR));
      return;
    }
    return res.json(deletedContact);

  })
};
