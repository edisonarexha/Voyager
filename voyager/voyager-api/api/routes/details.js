import express from "express";
import detailsController from "../controllers/details";
import validate from "../utils/functions/validate";
import detailsSchema from "../validators/details";

const detailsRoute = express.Router();

detailsRoute.get("/list", detailsController.list);

detailsRoute
  .route("/:id")
  .get(validate(detailsSchema.validateId), detailsController.get);

detailsRoute
  .route("/create")
  .post(validate(detailsSchema.post), detailsController.post);

detailsRoute.route("/update").put(validate(detailsSchema.put), detailsController.put);

detailsRoute
  .route("/delete/:id")
  .delete(validate(detailsSchema.validateId), detailsController.delete);

export default detailsRoute;