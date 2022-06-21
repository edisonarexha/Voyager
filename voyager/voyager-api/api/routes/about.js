import express from "express";
import aboutController from "../controllers/about";
import validate from "../utils/functions/validate";
import aboutSchema from "../validators/about";

const aboutRoute = express.Router();

aboutRoute.get("/list", aboutController.list);

aboutRoute
  .route("/:id")
  .get(validate(aboutSchema.validateId), aboutController.get);

aboutRoute
  .route("/create")
  .post(validate(aboutSchema.post), aboutController.post);

aboutRoute.route("/update").put(validate(aboutSchema.put), aboutController.put);

aboutRoute
  .route("/delete/:id")
  .delete(validate(aboutSchema.validateId), aboutController.delete);

export default aboutRoute;