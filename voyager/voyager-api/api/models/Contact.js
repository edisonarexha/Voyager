import mongoose from "mongoose";

const ContactSchema = new mongoose.Schema({
  name: String,
  message: String,
  email: String,
  subject: String,
  isDeleted: {
    type: Boolean,
    default: false,
  },
},
{
  versionKey: false,
});

const Contact = mongoose.model("Contact", ContactSchema);

export default Contact;
