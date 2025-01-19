# Aidn News Frontend

## Getting Started

1. Install Dependencies

```bash
npm install
```

2. Create an `.env.development` file with the proper URL (clone the `.env.example`)

3. Run the Development Server

```bash
npm run dev
```

Open [http://localhost:3000](http://localhost:3000) with your browser to see the result.


## Technologies

* NextJS - v. 15+ (using app router)
* React - v. 19
* TypeScript - v. 5
* TailwindCSS


## Improvements

* Add Storybook
This allows us to quickly develop and test and develop our components UI in isolation

* Add Tests for Components
  * ScoreCard should render when score is Defined
  * ScoreCard should not render if score is undefined


## Notes:

The `NewsForm` inputs have min max values to help safegaurd the user into using the correct values. If you comment out the min max props, you will see that a message appears stating a field is out of range (from backend)
