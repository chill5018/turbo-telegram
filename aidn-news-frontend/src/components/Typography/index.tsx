import { JSX } from "react";
import { TextVariants, TypographyProps } from "./types"
import styles from './styles.module.css';

type Tag = 'h2' | 'h3' | 'p';




export const Typography = ({
  variant = TextVariants.standard16,
  color = "primary",
  className,
  children }: TypographyProps) => {

  const Tag: keyof JSX.IntrinsicElements = (() => {
    switch (variant) {
      case 'header2':
        return 'h2';
      case 'header3':
        return 'h3';
      default:
        return 'p';
    }

  })()

  const classes = `${styles.typography} ${styles[variant]} ${styles[color]} ${className || ""}`.trim();

  return (
    <Tag className={classes}>
      {children}
    </Tag>
  )
}
