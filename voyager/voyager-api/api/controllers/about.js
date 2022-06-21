import About from "../models/About";
const asyncHandler = require("../middlewares/asyncHandler");
const { ApiError } = require("../utils/classes");
const { statusCodes } = require("../config");

export default {
  list: asyncHandler(async (req, res) => {
    const list = await About.find({ isDeleted: false });
    if (!list) {
      next(new ApiError("Cannot list about!", statusCodes.BAD_REQUEST));
      return;
    }
    return res.json(list);
  }),

  get: asyncHandler(async (req, res) => {
    const { id } = req.params;
    const foundItem = await About.findOne({ _id: id });

    if (!foundItem) {
      next(new ApiError("Cannot find about!", statusCodes.BAD_REQUEST));
      return;
    }

    return res.json(foundItem);
  }),

  post: asyncHandler(async (req, res) => {
    const about = await About.create({
      ...req.body,
    });
    if (!about) {
      next(new ApiError("Cannot create about!", statusCodes.BAD_REQUEST));
      return;
    }

    return res.json(about);
  }),

  put: asyncHandler(async (req, res) => {
    const about = req.body;

    const updatedAbout = await About.findOneAndUpdate(
      { _id: about._id },
      {
        $set: {
          ...about
        },
      },
      { new: true }
    );

    if (!updatedAbout) {
      next(new ApiError("Failed to update about!", statusCodes.BAD_REQUEST));
      return;
    }

    return res.json(updatedAbout);
  }),
  delete: asyncHandler(async (req, res, next) => {
    const { id } = req.params;
    const foundItem = await About.findOne({
      _id: id,
      isDeleted: false,
    });

    if (!foundItem) {
      next(new ApiError("About not found with id!", statusCodes.NOT_FOUND));
      return;
    }

    const deletedAbout = await About.findOneAndUpdate(
      { _id: foundItem._id },
      {
        $set: {
          isDeleted: true,
        },
      },
      { new: true }
    );
    if (!deletedAbout) {
      next(new ApiError("Failed to delete about!", statusCodes.INTERNAL_ERROR));
      return;
    }

    return res.json(deletedAbout);
  }),
};