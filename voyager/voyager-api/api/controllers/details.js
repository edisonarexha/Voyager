import Details from "../models/Details";
const asyncHandler = require("../middlewares/asyncHandler");
const { ApiError } = require("../utils/classes");
const { statusCodes } = require("../config");

export default {
  list: asyncHandler(async (req, res) => {
    const list = await Details.find({ isDeleted: false });
    if (!list) {
      next(new ApiError("Cannot list details!", statusCodes.BAD_REQUEST));
      return;
    }
    return res.json(list);
  }),

  get: asyncHandler(async (req, res) => {
    const { id } = req.params;
    const foundItem = await Details.findOne({ _id: id });

    if (!foundItem) {
      next(new ApiError("Cannot find details!", statusCodes.BAD_REQUEST));
      return;
    }

    return res.json(foundItem);
  }),

  post: asyncHandler(async (req, res) => {
    const details = await Details.create({
      ...req.body,
    });
    if (!details) {
      next(new ApiError("Cannot create details!", statusCodes.BAD_REQUEST));
      return;
    }

    return res.json(details);
  }),

  put: asyncHandler(async (req, res) => {
    const details = req.body;

    const updatedDetails = await Details.findOneAndUpdate(
      { _id: details._id },
      {
        $set: {
          ...details
        },
      },
      { new: true }
    );

    if (!updatedDetails) {
      next(new ApiError("Failed to update details!", statusCodes.BAD_REQUEST));
      return;
    }

    return res.json(updatedDetails);
  }),
  delete: asyncHandler(async (req, res, next) => {
    const { id } = req.params;
    const foundItem = await Details.findOne({
      _id: id,
      isDeleted: false,
    });

    if (!foundItem) {
      next(new ApiError("Details not found with id!", statusCodes.NOT_FOUND));
      return;
    }

    const deletedDetails = await Details.findOneAndUpdate(
      { _id: foundItem._id },
      {
        $set: {
          isDeleted: true,
        },
      },
      { new: true }
    );
    if (!deletedDetails) {
      next(new ApiError("Failed to delete details!", statusCodes.INTERNAL_ERROR));
      return;
    }

    return res.json(deletedDetails);
  }),
};