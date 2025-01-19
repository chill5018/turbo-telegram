'use client'
import { ButtonProps } from "./types";
import styles from './styles.module.css';
import { Typography } from "../Typography";

export const Button = ({ variant, type, className, children, ...props }: ButtonProps) => {

  const cssClasses = `${styles.button} ${styles[variant]} ${className || ''}`.trim();
  const typographyColor = variant === 'primary' ? 'secondary' : 'primary';
  return (
    <button type={type} className={cssClasses} {...props}>
      <Typography color={typographyColor}>
        {children}
      </Typography>
    </button>
  )
}
