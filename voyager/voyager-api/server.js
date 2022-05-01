import express from "express";
import getAuthToken from "./api/middlewares/getAuthToken";
import userRouter from "./api/routes/users";
import cors from "cors";
import helmet from "helmet";

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


app.listen(port, () => {
  console.log(`Voyager server listening on ${port}`);
});
