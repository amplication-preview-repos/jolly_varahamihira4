import * as React from "react";
import {
  Create,
  SimpleForm,
  CreateProps,
  TextInput,
  SelectInput,
} from "react-admin";

export const EmployeeCreate = (props: CreateProps): React.ReactElement => {
  return (
    <Create {...props}>
      <SimpleForm>
        <TextInput label="City" source="city" />
        <TextInput label="Country" source="country" />
        <TextInput label="Designation" source="designation" />
        <SelectInput
          source="gender"
          label="Gender"
          choices={[{ label: "Option 1", value: "Option1" }]}
          optionText="label"
          allowEmpty
          optionValue="value"
        />
        <TextInput label="Name" source="name" />
      </SimpleForm>
    </Create>
  );
};
