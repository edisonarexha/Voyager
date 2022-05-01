import express from "express";
import userController from "../controllers/users";
import checkIfAdmin from "../middlewares/checkIfAdmin";

const userRouter = express.Router({
  mergeParams: true,
});

userRouter.post("/register", userController.register);

userRouter.use(checkIfAdmin);


export default userRouter;
