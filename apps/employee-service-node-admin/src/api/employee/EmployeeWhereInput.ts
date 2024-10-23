import { StringNullableFilter } from "../../util/StringNullableFilter";
import { StringFilter } from "../../util/StringFilter";

export type EmployeeWhereInput = {
  city?: StringNullableFilter;
  country?: StringNullableFilter;
  designation?: StringNullableFilter;
  gender?: "Option1";
  id?: StringFilter;
  name?: StringNullableFilter;
};
