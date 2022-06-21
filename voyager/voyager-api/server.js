import express from "express";
import mongoose from "mongoose";
import getAuthToken from "./api/middlewares/getAuthToken";
import userRouter from "./api/routes/users";
import cors from "cors";
import helmet from "helmet";
import contactRoute from "./api/routes/contact";
import aboutRoute from "./api/routes/about";
import detailsRoute from "./api/routes/details";


mongoose.connect("mongodb://localhost:27017/voyager-db").then(() => {
  console.log("Mongodb is connected, port: 27017");
});

const app = express();

const port = process.env.PORT || 3000;

app.use(
  cors({
    origin: "*",
  })
);

app.use(helmet());

app.use(
  express.urlencoded({
    extended: true,
  })
);

app.use(express.json());

app.use(getAuthToken);

app.use("/users", userRouter);
app.use("/contact", contactRoute);
app.use("/about", aboutRoute);
app.use("/about", detailsRoute);


app.listen(port, () => {
  console.log(`Voyager server listening on ${port}`);
});
