import { Typography } from "../Typography"
import { TextVariants } from "../Typography/types"
import { InputFieldProps } from "./types";

import styles from './styles.module.css';

export const InputField = ({ title, description, className, name, ...props }: InputFieldProps) => {

  const cssClasses = `${styles.input}`;

  return (
    <div>
      <Typography variant={TextVariants.header3} className="mb-2">
        {title}
      </Typography>
      {description ? <Typography variant={TextVariants.small14} className="mb-3">
        {description}
      </Typography> : null}
      <input name={name} className={cssClasses} {...props} />
    </div>
  )
}
