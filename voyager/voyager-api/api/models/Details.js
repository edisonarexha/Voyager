import mongoose from "mongoose";

const DetailsSchema = new mongoose.Schema(
  {
    email: String,
    phone: String,
    address: String,
    website: String,
    isDeleted: {
      type: Boolean,
      default: false,
    },
  },
  {
    versionKey: false,
  }
);

const About = mongoose.model("Details", DetailsSchema);

export default About;