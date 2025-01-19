
export type TypographyProps = {
  children: React.ReactNode;
  variant?: TextVariants;
  color?: 'primary' | 'secondary';
  className?: string;
}


export enum TextVariants {
  header2 = 'header2',
  header3 = 'header3',
  standard16 = 'standard16',
  standard20 = 'standard20',
  small14 = 'small14'

}
