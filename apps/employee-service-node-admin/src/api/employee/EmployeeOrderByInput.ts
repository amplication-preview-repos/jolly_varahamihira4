import { SortOrder } from "../../util/SortOrder";

export type EmployeeOrderByInput = {
  city?: SortOrder;
  country?: SortOrder;
  createdAt?: SortOrder;
  designation?: SortOrder;
  gender?: SortOrder;
  id?: SortOrder;
  name?: SortOrder;
  updatedAt?: SortOrder;
};
