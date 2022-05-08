import express from "express";
import contactController from "../controllers/contact";
import contactsSchema from "../validators/contact";
import validate from "../utils/functions/validate";

const contactRoute = express.Router();

contactRoute.get("/list", contactController.list);


contactRoute
  .route("/:id")
  .get(validate(contactsSchema.validateId), contactController.get);


contactRoute
.route("/create")
.post(validate(contactsSchema.post), contactController.post);

contactRoute.route("/update").put(validate(contactsSchema.put), contactController.put);

contactRoute
  .route("/delete/:id")
  .delete(validate(contactsSchema.validateId), contactController.delete);

  export default contactRoute;
